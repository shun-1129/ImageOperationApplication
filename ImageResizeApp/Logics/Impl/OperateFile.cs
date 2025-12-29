using CommonLibrary.Models;
using CommonLibrary.Utilities;
using ImageResizeApp.Models;
using System.Text.RegularExpressions;

namespace ImageResizeApp.Logics.Impl
{
    public class OperateFile
    {
        #region メンバ変数
        #endregion

        #region プロパティ
        #endregion

        #region コンストラクタ
        public OperateFile () { }
        #endregion

        #region メソッド
        #region publicメソッド
        public Result ExecuteZipFileRemane ( string sourceFilePath )
        {
            Result result = Result.Success ();

            try
            {
                string newFileName = ChangeFileName ( sourceFilePath );
                newFileName = DeleteTargetName ( newFileName );

                string tempFileName = SwapFileName ( newFileName );
                newFileName = !string.IsNullOrEmpty ( tempFileName ) ? tempFileName : newFileName;

                tempFileName = SwapFileNameMonth ( newFileName );
                newFileName = !string.IsNullOrEmpty ( tempFileName ) ? tempFileName : newFileName;

                tempFileName = SwapTargetVol ( newFileName );
                newFileName = !string.IsNullOrEmpty ( tempFileName ) ? tempFileName : newFileName;

                string newFilePath = Path.Combine ( SelectedFolderSetting.Instance.WorkFolderPath , newFileName );
                if ( newFilePath.Equals ( sourceFilePath ) )
                {
                    return result;
                }

                FileUtil.MoveFile ( sourceFilePath , newFileName , SelectedFolderSetting.Instance.WorkFolderPath , isOverwriting: true );
            }
            catch ( Exception ex )
            {
                result = Result.Failure ( ex.Message , ex );
            }

            return result;
        }
        #endregion

        #region protectedメソッド
        #endregion

        #region internalメソッド
        #endregion

        #region privateメソッド
        /// <summary>
        /// ファイル名称変更
        /// </summary>
        /// <param name="sourceFilePath">ソースファイルパス</param>
        /// <returns>変更後ファイル名称</returns>
        private static string ChangeFileName ( string sourceFilePath )
        {
            string fileName = FileUtil.GetFileName(sourceFilePath, false);

            // 1文字目が '(' の場合、最初の '[' まで削除
            if ( fileName.StartsWith ( "(" ) )
            {
                int firstBracketIndex = fileName.IndexOf('[');
                if ( firstBracketIndex != -1 )
                {
                    fileName = fileName.Substring ( firstBracketIndex );
                }
                else
                {
                    // '[' が存在しない場合は全体を削除せずそのままにする
                    fileName = fileName.Substring ( fileName.IndexOf ( ')' ) + 1 ).Trim ();
                }
            }

            // []が2個連続の場合、最初の[]を削除
            while ( fileName.Contains ( "][" ) )
            {
                int firstBracketStart = fileName.IndexOf('[');
                int firstBracketEnd = fileName.IndexOf(']') + 1;
                if ( firstBracketStart != -1 && firstBracketEnd != -1 && firstBracketEnd < fileName.Length )
                {
                    fileName = fileName.Remove ( firstBracketStart , firstBracketEnd - firstBracketStart );
                }
                else
                {
                    break; // 異常ケースを防ぐ
                }
            }

            // トリムで余計な空白を除去
            return fileName.Trim ();
        }

        /// <summary>
        /// 削除対象名称 削除処理
        /// </summary>
        /// <param name="sourceFilePath">ソースファイルパス</param>
        /// <returns>ファイル名称</returns>
        private static string DeleteTargetName ( string sourceFilePath )
        {
            string fileName = FileUtil.GetFileName(sourceFilePath);
            string fileExtension = FileUtil.GetFileExtension(sourceFilePath);

            string changeFileName = fileName;

            foreach ( string target in Appsettings.Instance.DeleteTargets.DeleteTargetName )
            {
                string tempFileName = changeFileName.Replace(target, "").Trim();

                if ( !changeFileName.Equals ( tempFileName ) )
                {
                    changeFileName = tempFileName;
                }
            }

            return $"{changeFileName}{fileExtension}";
        }

        /// <summary>
        /// 指定名称差し替え
        /// </summary>
        /// <remarks>
        /// SwapTarget.jsonに設定された名称を入れ替える
        /// </remarks>
        /// <param name="sourceFilePath">ソースファイルパス</param>
        /// <returns>ファイル名称</returns>
        private static string SwapFileName ( string sourceFilePath )
        {
            try
            {
                string newFileName = FileUtil.GetFileName(sourceFilePath, false);

                foreach ( List<string> swapTarget in Appsettings.Instance.FileNameChangeSettings.SwapTarget )
                {
                    string tempFileName = Regex.Replace(newFileName, swapTarget[0], swapTarget[1]);

                    if ( !newFileName.Equals ( tempFileName ) )
                    {
                        newFileName = tempFileName;
                    }
                }

                return newFileName;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// ファイル名称の年月の差し替え
        /// </summary>
        /// <param name="sourceFilePath">ソースファイルパス</param>
        /// <returns>ファイル名称</returns>
        private static string SwapFileNameMonth ( string sourceFilePath )
        {
            try
            {
                string newFileName = FileUtil.GetFileName(sourceFilePath, false);

                foreach ( List<string> swapTargetMonth in Appsettings.Instance.FileNameChangeSettings.SwapTargetMonth )
                {
                    for ( int year = 2010 ; year <= 2030 ; year++ )
                    {
                        string sourceTarget = $"{year.ToString()}年{swapTargetMonth[0]}";
                        string destTarget = $"{year.ToString()}年{swapTargetMonth[1]}";

                        string tempFileName = Regex.Replace(newFileName, sourceTarget, destTarget);

                        if ( !newFileName.Equals ( tempFileName ) )
                        {
                            newFileName = tempFileName;
                        }
                    }
                }

                return newFileName;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Vol差し替え
        /// </summary>
        /// <param name="sourceFilePath">ソースファイルパス</param>
        /// <returns>ファイル名称</returns>
        private static string SwapTargetVol ( string sourceFilePath )
        {
            try
            {
                string fileName = FileUtil.GetFileName(sourceFilePath, false);
                string newFileName = Regex.Replace(fileName, @"Vol\.(\d+)", match =>
                {
                    int volNumber = int.Parse(match.Groups[1].Value);
                    return $"Vol.{volNumber:000}";  // 3桁にゼロ埋め
                });

                return newFileName;
            }
            catch
            {
                return string.Empty;
            }
        }
        #endregion
        #endregion
    }
}
