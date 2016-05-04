namespace MyUtilities
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Text;

    public class CSVHelper
    {
        public static char charDelimiter = ',';
        public static char charEscapeQuote = '\\';
        public static char charQuote = '"';
        public static int chrCarriageReturn = 13;
        public static int chrDelimiter = charDelimiter;
        public static int chrEscapeQuote = charEscapeQuote;
        public static int chrNewLine = 10;
        public static int chrQuote = charQuote;

        public static string[] ParseCSVString(string strCSV, char chrDelimiter = ',', char chrQuote = '"', char chrEscapeQuote = '\\')
        {
            bool flag = false;
            bool flag2 = false;
            int num = 0;
            int num2 = 0;
            List<string> list = new List<string>();
            StringBuilder builder = new StringBuilder();
            StringReader reader = new StringReader(strCSV);
            while ((num = reader.Read()) >= 0)
            {
                if (num == chrQuote)
                {
                    if (((!flag && flag2) && (chrQuote == chrEscapeQuote)) && (chrQuote == reader.Peek()))
                    {
                        flag = true;
                    }
                    else if (flag)
                    {
                        builder.Append((char) num);
                        flag = false;
                    }
                    else
                    {
                        flag2 = !flag2;
                        if (!flag2)
                        {
                            int num3 = reader.Peek();
                            if ((((num3 != chrDelimiter) && (num3 != chrCarriageReturn)) && (num3 != chrNewLine)) && (num2 == chrDelimiter))
                            {
                                string item = builder.ToString().TrimEnd(new char[] { chrDelimiter });
                                list.Add(item);
                                flag2 = true;
                                builder.Clear();
                            }
                        }
                    }
                }
                else if ((num == chrEscapeQuote) && flag2)
                {
                    flag = true;
                }
                else if (num == chrDelimiter)
                {
                    if (flag2)
                    {
                        builder.Append((char) num);
                    }
                    else
                    {
                        list.Add(builder.ToString());
                        builder.Clear();
                    }
                }
                else if (num == chrCarriageReturn)
                {
                    bool flag3 = false;
                    if (reader.Peek() == chrNewLine)
                    {
                        flag3 = true;
                        reader.Read();
                    }
                    if (!flag2)
                    {
                        break;
                    }
                    builder.Append((char) num);
                    if (flag3)
                    {
                        builder.Append((char) chrNewLine);
                    }
                }
                else if (num == chrNewLine)
                {
                    if (!flag2)
                    {
                        break;
                    }
                    builder.Append((char) num);
                }
                else
                {
                    builder.Append((char) num);
                }
                num2 = num;
            }
            if ((builder.Length > 0) || (num2 == chrDelimiter))
            {
                list.Add(builder.ToString());
            }
            return list.ToArray();
        }
    }
}

