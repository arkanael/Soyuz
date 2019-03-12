using System.Collections;
using System.Linq;
using System.Web.Http.ModelBinding;

namespace Soyuz.Presentation.Utilitarios
{
    public class ValidationsUtil
    {
        public static Hashtable GetErrorMessages(ModelStateDictionary ModelState)
        {
            var erros = new Hashtable();

            foreach (var state in ModelState)
            {
                if (state.Value.Errors.Count > 0)
                {
                    erros[state.Key] = state.Value.Errors.Select(e => e.ErrorMessage).ToList();
                }
            }

            return erros;
        }
    }
}