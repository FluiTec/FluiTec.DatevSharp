using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluiTec.DatevSharp
{
    /// <summary>   A data Model for the string. </summary>
    public class StringModel
    {
        /// <summary>   Constructor. </summary>
        /// <param name="targetLengths">    List of lengths of the targets. </param>
        /// <param name="sourceValues">  A variable-length parameters list containing source values. </param>
        public StringModel(IEnumerable<int> targetLengths, params string[] sourceValues)
        {
            TargetLengths = targetLengths.ToList();
            TargetStrings = TargetLengths.Select(l => string.Empty).ToList();

            var sb = new StringBuilder();
            foreach (var value in sourceValues)
                if (!string.IsNullOrWhiteSpace(value))
                    sb.AppendLine(value);

            if (!FitDefault(sourceValues))
                if (!FitByWord(sourceValues))
                    if (!FitUgly(sourceValues))
                        throw new NotImplementedException("CustomerString was too long to handle...");
        }

        private List<int> TargetLengths { get; }
        public List<string> TargetStrings { get; private set; }

        /// <summary>	Fit default. </summary>
        /// <param name="lines">	The lines. </param>
        /// <returns>	True if it succeeds, false if it fails. </returns>
        private bool FitDefault(string[] lines)
        {
            if (lines.Where((t, i) => !(t == null || t.Length <= TargetLengths[i])).Any())
                return false;

            var counter = 0;
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                TargetStrings[counter] = line;
                counter++;
            }

            return true;
        }

        /// <summary>	Fit by word. </summary>
        /// <param name="lines">	The lines. </param>
        /// <returns>	True if it succeeds, false if it fails. </returns>
        private bool FitByWord(string[] lines)
        {
            var words = string.Join(" ", lines.Where(line => !string.IsNullOrWhiteSpace(line))).Split(' ');

            var internalLines = TargetLengths.Select(l => string.Empty).ToList();
            var lineCounter = 0;
            var charsLeft = TargetLengths[lineCounter];
            foreach (var word in words)
                if (charsLeft >= word.Length + 1)
                {
                    internalLines[lineCounter] += $"{word} ";
                    charsLeft = TargetLengths[lineCounter] - internalLines[lineCounter].Length;
                }
                else
                {
                    if (lineCounter < TargetLengths.Count - 1) // lines left
                    {
                        lineCounter++;
                        charsLeft = TargetLengths[lineCounter] - internalLines[lineCounter].Length;
                        if (charsLeft >= word.Length + 1)
                        {
                            internalLines[lineCounter] += $"{word} ";
                            charsLeft = TargetLengths[lineCounter] - internalLines[lineCounter].Length;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

            TargetStrings = internalLines;
            return true;
        }

        /// <summary>	Fit ugly. </summary>
        /// <param name="lines">	The lines. </param>
        /// <returns>	True if it succeeds, false if it fails. </returns>
        private bool FitUgly(string[] lines)
        {
            var content = string.Join("", lines);
            var start = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                TargetStrings[i] = content.Substring(start, TargetLengths[i]);
                start += TargetLengths[i] + 1;
            }

            if (start + TargetLengths[lines.Length - 1] < content.Length)
                return false;
            return true;
        }
    }
}