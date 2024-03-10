namespace AKM.Server.Library.Impl.Helpers
{
    public class Validators
    {
        public static bool isValidUpdateDTO(Object obj)
        {
            var idProperty = obj.GetType().GetProperty("id");
            var idValue = idProperty?.GetValue(obj);

            return idValue == null || obj.GetType().GetProperties().All(prop => prop.GetValue(obj) == null);
        }
    }
}
