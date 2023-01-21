
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;



namespace Api_Integrated_Test
{
   
    public class Branch1
    {
        

     
        public string WriteResultTextBox(string newStr)
        {
            return newStr + System.Environment.NewLine;
        }
        public async Task<string> Response_writeTofileAsync(HttpResponseMessage Response)
        {

            string generateStr;
            //Writing text to the file.
            generateStr =DateTime.Now.ToString() + System.Environment.NewLine;

            generateStr += "StatusCode :" + Response.StatusCode.ToString() + System.Environment.NewLine;
           // generateStr += "STatusCode :" + Response.StatusCode.ToString() + System.Environment.NewLine;

            if(Response.StatusCode != System.Net.HttpStatusCode.RequestTimeout)
            {
                
                try
                {
                    string ContentStr = await Response.Content.ReadAsStringAsync();
                    ContentStr = ContentStr.Replace("{", "{"+ System.Environment.NewLine);
                    ContentStr = ContentStr.Replace("}", System.Environment.NewLine + "}");
                    ContentStr = ContentStr.Replace(",", "," + System.Environment.NewLine);
                    ContentStr = ContentStr.Replace("[", "[" + System.Environment.NewLine);
                    ContentStr = ContentStr.Replace("]",  System.Environment.NewLine + "]");



                    generateStr += "//////////Body :" + System.Environment.NewLine+ System.Environment.NewLine;
                    generateStr += ContentStr + System.Environment.NewLine;
                }
                catch (Exception e)
                {
                    generateStr += "Error   :  Cant convert Body To String ..." + System.Environment.NewLine;

                }
            }
            

            return generateStr;


        }
		public void branch1EitclientTestconfilig()
		{
			
		}
		public void branch1EitclientTestconfilig1()
		{
			
		}

        public void branch1Testconfilig()
		{
			//add from eit
			//add from eit 2
			
		}

    }
}
