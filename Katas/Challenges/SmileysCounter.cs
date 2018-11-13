using System.Linq;
using System.Text.RegularExpressions;

namespace Katas.Challenges
{
    public static class SmileysCounter
    {
        /// <summary>
        /// Given an array (arr) as an argument complete the function CountSmileys that should return the total number of smiling faces.
        /// -Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
        /// -A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
        /// -Every smiling face must have a smiling mouth that should be marked with either ) or D.
        /// No additional characters are allowed except for those mentioned.
        /// Valid smiley face examples:
        /// :) :D ;-D :~)
        /// Invalid smiley faces:
        /// ;( :&gt; :} :] 
        /// </summary>
        /// <param name="smileys"></param>
        /// <returns></returns>
        public static int CountSmileys(string[] smileys)
        {
            var withoutNose = new Regex("^[:;]+[D)]");
            var withNose = new Regex("^[:;]+[-~]+[D)]");
            return smileys.Count(smiley => withoutNose.IsMatch(smiley) || withNose.IsMatch(smiley));
        }
    }
}
