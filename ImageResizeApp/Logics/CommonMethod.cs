using CommonLibrary.Utilities.Impl;
using System.Text.RegularExpressions;
using static CommonLibrary.Constants.Constants;

namespace ImageResizeApp.Models.Logics
{
    /// <summary>
    /// 共通メソッドクラス
    /// </summary>
    public class CommonMethod
    {
        /// <summary>
        /// ファイル名称変更
        /// </summary>
        /// <param name="sourceFilePath">ソースファイルパス</param>
        /// <returns>変更後ファイル名称</returns>
        public static string ChangeFileName ( string sourceFilePath )
        {
            string fileName = FileOperation.GetFileName(sourceFilePath, false);

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
        /// <param name="sourceFilePath"></param>
        /// <returns></returns>
        public static string DeleteTargetName ( string sourceFilePath )
        {
            string fileName = FileOperation.GetFileName(sourceFilePath);
            string fileExtension = FileOperation.GetFileExtension(sourceFilePath);

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
        /// 
        /// </summary>
        /// <param name="sourceFilePath"></param>
        /// <param name="fileExtension"></param>
        /// <param name="directoryPath"></param>
        /// <returns></returns>
        public static string ChangeFileExtension ( string sourceFilePath , string fileExtension = FileExtension.JPEG , string directoryPath = "" )
        {
            string fileName = FileOperation.GetFileName(sourceFilePath);
            string newFileName = $"{fileName}{fileExtension}";

            if ( string.IsNullOrEmpty ( directoryPath ) )
            {
                return newFileName;
            }
            else
            {
                return Path.Combine ( directoryPath , newFileName );
            }
        }


        #region フォルダ振り分け関連
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootPath"></param>
        /// <param name="directoryName"></param>
        public static string CreateDirectory ( string rootPath , string directoryName )
        {
            string directoryPath = Path.Combine(rootPath, directoryName);

            if ( !Directory.Exists ( directoryPath ) )
            {
                Directory.CreateDirectory ( directoryPath );
            }

            return directoryPath;
        }

        /// <summary>
        /// 作者名称
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetCreator ( string filePath )
        {
            string fileName = FileOperation.GetFileName(filePath);

            // 正規表現パターン: \\[(.*?)\\]
            string pattern = @"\[(.*?)\]";
            Match match = Regex.Match(fileName, pattern);

            if ( match.Success )
            {
                string extracted = match.Groups[1].Value; // グループ1が角括弧内の文字列
                return extracted;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// ()削除
        /// </summary>
        /// <param name="creatorName">作者名称</param>
        /// <returns>作者名称</returns>
        public static string DeleteBrackets ( string creatorName )
        {
            // 正規表現パターン: \\(.*?\\)
            string pattern = @"\s*\(.*?\)";
            string result = Regex.Replace(creatorName, pattern, string.Empty);

            return result;
        }
        #endregion
    }
}
