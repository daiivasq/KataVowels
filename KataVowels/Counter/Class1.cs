using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Counter
{
    
    /// <summary>
    ///  hey olas
    /// </summary>
    public class VowelsCounter
    {
        /// <param name="text"></param>
        public static bool ImputValidation(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException();
                return true;

            }
            else if (text.Length == 0) return true;
            else return false;
        }
        public static List<string> Count(string text)
        { 

            List<string> list = new List<string>();
 
            var vocales = new[] { 'a','e','i','o','u'};
            if (ImputValidation(text)) return list;
            else
            {
                var parameter = text.ToLower();
 
                vocales.OfType<char>().ToList().ForEach(maches => {
                    var context  = parameter.Count(x => x == maches);
                    if(context > 0) list.Add($"{maches} = {context}");
                });
            }
            return list;
        }
        
    }
}
