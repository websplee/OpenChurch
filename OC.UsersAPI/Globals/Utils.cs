namespace OC.UsersAPI.Globals
{
    public class Utils
    {
        public static string Base64ImageToFileImage(string base64Image, string recordType, string recordId)
        {
            var bytes = Convert.FromBase64String(base64Image);// a.base64Image 
            //or full path to file in temp location
            //var filePath = Path.GetTempFileName();

            // full path to file in current project location
            string filedir = Path.Combine(Directory.GetCurrentDirectory(), $"images/{recordType}");

            if (!Directory.Exists(filedir))
            { //check if the folder exists;
                Directory.CreateDirectory(filedir);
            }
            string fileName = $"{recordType}_UID_" + recordId + ".jpg";

            // Does it overwrite by default

            string file = Path.Combine(filedir, fileName);            

            if (bytes.Length > 0)
            {
                using (var stream = new FileStream(file, FileMode.Create))
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                }
            }
            return file;
        }
    }
}
