﻿using System;
using System.Text.RegularExpressions;

namespace Forms9Patch
{
    /// <summary>
    /// Forms9Patch String extensions.
    /// </summary>
    public static class StringExtensions
    {
        static string EmailRegexString = @"(?:(?:\r\n)?[ \t])*(?:(?:(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t]
)+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:
\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(
?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ 
\t]))*""(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\0
31]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\
](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+
(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:
(?:\r\n)?[ \t])*))*|(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z
|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)
?[ \t])*)*\<(?:(?:\r\n)?[ \t])*(?:@(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\
r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[
 \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)
?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t]
)*))*(?:,@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[
 \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*
)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t]
)+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*)
*:(?:(?:\r\n)?[ \t])*)?(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+
|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r
\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:
\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t
]))*""(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031
]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](
?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?
:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?
:\r\n)?[ \t])*))*\>(?:(?:\r\n)?[ \t])*)|(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?
:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?
[ \t]))*""(?:(?:\r\n)?[ \t])*)*:(?:(?:\r\n)?[ \t])*(?:(?:(?:[^()<>@,;:\\"".\[\] 
\000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|
\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>
@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""
(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t]
)*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\
"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?
:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[
\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*|(?:[^()<>@,;:\\"".\[\] \000-
\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(
?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*)*\<(?:(?:\r\n)?[ \t])*(?:@(?:[^()<>@,;
:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([
^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\""
.\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\
]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*(?:,@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\
[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\
r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] 
\000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]
|\\.)*\](?:(?:\r\n)?[ \t])*))*)*:(?:(?:\r\n)?[ \t])*)?(?:[^()<>@,;:\\"".\[\] \0
00-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\
.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,
;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|""(?
:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*
(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".
\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[
^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\]
]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*\>(?:(?:\r\n)?[ \t])*)(?:,\s*(
?:(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\
"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*)(?:\.(?:(
?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[
\[""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t
])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t
])+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?
:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|
\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*|(?:
[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".\[\
]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*)*\<(?:(?:\r\n)
?[ \t])*(?:@(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""
()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)
?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>
@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*(?:,@(?:(?:\r\n)?[
 \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,
;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t]
)*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\
"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*)*:(?:(?:\r\n)?[ \t])*)?
(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[""()<>@,;:\\"".
\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:
\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\[
""()<>@,;:\\"".\[\]]))|""(?:[^\""\r\\]|\\.|(?:(?:\r\n)?[ \t]))*""(?:(?:\r\n)?[ \t])
*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])
+|\Z|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\
.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\"".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z
|(?=[\[""()<>@,;:\\"".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*\>(?:(
?:\r\n)?[ \t])*))*)?;\s*)".Replace(Environment.NewLine, "");

        static Regex EmailRegex = new Regex(EmailRegexString);

        /// <summary>
        /// Tests if string is a valid email address
        /// </summary>
        /// <returns><c>true</c>, if valid email, <c>false</c> otherwise.</returns>
        /// <param name="strIn">String in.</param>
        public static bool IsValidEmail(this string strIn)
        {
            if (string.IsNullOrWhiteSpace(strIn))
                return false;
            return EmailRegex.IsMatch(strIn);
        }

        /// <summary>
        /// Determines if two version strings are the same
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static int CompareVersionStrings(this string s1, string s2)
        {
            if (s1 == null && s2 == null)
                return 0;

            if (s1 == null)
                return 1;

            if (s2 == null)
                return -1;

            var s1Blocks = s1.Split('.');
            var s2Blocks = s2.Split('.');

            for (int i=0; i < Math.Min(s1Blocks.Length, s2Blocks.Length); i++)
            {
                var s1b = s1Blocks[i].Trim();
                var s2b = s2Blocks[i].Trim();
                var l1 = s1b.Length;
                var l2 = s2b.Length;

                for (int j=0; j< Math.Min(l1, l2);j++)
                {
                    var c1 = (s1b)[l1 - 1 - j];
                    var c2 = (s2b)[l2 - 1 - j];
                    var cComp = c1 - c2;
                    if (cComp != 0)
                        return cComp;
                }
                var lComp = l1 - l2;
                if (lComp != 0)
                    return lComp;
            }

            var bComp = s1Blocks.Length - s2Blocks.Length;
            return bComp;
        }

    }
}
