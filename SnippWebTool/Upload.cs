using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace SnippTool
{
    class Upload
    {

        public static int imageNumberName;
        
        /// <summary>
        /// Uploads image via POST to the server
        /// </summary>
        /// <param name="postStreamImageArray">Image converted to stream array</param>
        public async void UploadImageWithPost(byte[] postStreamImageArray)
        {
            DateTime time = DateTime.Now;
            string userTime = time.ToString("yyyy-MM-dd HH:mm:ss");

            string actionUrl = "http://host-image.hol.es/image-upload.php";
            string imageName = "desk_app_" + System.Environment.MachineName + ".png";

            using (var client = new HttpClient())
            using (MemoryStream postStream = new MemoryStream(postStreamImageArray))
            {
                HttpContent fileStreamContent = new StreamContent(postStream);
                HttpContent timeStreamContent = new StringContent(userTime);
                var formData = new MultipartFormDataContent();
                formData.Add(fileStreamContent, "fileToUpload", imageName);
                formData.Add(timeStreamContent, "time");

                var response = client.PostAsync(actionUrl, formData);
                var responseString = await response.Result.Content.ReadAsStringAsync();

                dynamic responseJson = JsonConvert.DeserializeObject(responseString);
                String errorMessage = responseJson.error_message;
                String responseUrl = responseJson.image_url;
                if (!String.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show("Error during upload. File is not uploaded. File is not an image!");
                }else
                {
                    Process.Start(responseUrl);
                }
            }
        }

    }
}
