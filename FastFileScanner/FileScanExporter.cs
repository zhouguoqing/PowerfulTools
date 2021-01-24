using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFileScanner
{
    class FileScanExporter
    {
        public static string ExportCSV(string filePath, List<ScanFileInfo> checkResults)
        {
            var csvFile = Path.Combine(filePath, "文件扫描结果-" + DateTime.Now.ToString("yyyyMMddHHmm") + ".csv");

            StringBuilder builder = new StringBuilder();
            List<string> columnNames = new List<string>();
            if (checkResults.FirstOrDefault() is ScanFileInfo)
            {
                columnNames.Add("文件名称");
                columnNames.Add("文件大小");
                columnNames.Add("文件类型");
                columnNames.Add("文件最后修改时间");
                columnNames.Add("文件所在目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
                columnNames.Add("子目录");
            }

            builder.Append(string.Join(",", columnNames.ToArray())).Append("\n");

            var rows = new List<string>();
            foreach (var result in checkResults)
            {
                var currentRow = new List<string>() { result.FileName, result.FileSize.ToString(), result.Extension, result.LastModifyTime.ToString(),
                    result.FilePath,result.SubDir1, result.SubDir2,result.SubDir3,result.SubDir4,result.SubDir5,result.SubDir6,result.SubDir7,result.SubDir8,result.SubDir9,result.SubDir10,result.SubDir11,result.SubDir12 };
                rows.Add(string.Join(",", currentRow.ToArray()));
            }

            builder.Append(string.Join("\n", rows.ToArray()));

            byte[] CSVBinaryData = Encoding.UTF8.GetBytes(builder.ToString());
            CSVBinaryData = Encoding.UTF8.GetPreamble().Concat(CSVBinaryData).ToArray();
            File.WriteAllBytes(csvFile, CSVBinaryData);

            return csvFile;
        }
    }
}
