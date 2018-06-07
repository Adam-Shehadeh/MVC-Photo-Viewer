using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;

namespace MVC_Photo_Viewer.Controllers {
    public static class PhotoService {

        private static readonly string ROOT = "C:\\Users\\AShehadeh\\D&W Fine Pack\\Marketing Communications - Product Photos\\";
        //Takes list of string file names. Example: 1074.jpg, 1111.jpg, B95.png
        //Returns list of byte strings for photos, sent to view
        public static string getPhotoData(string name) {
            string local = string.Empty;    //Will propogate with return values
            try {
                string fullpath = ROOT + name;
                Image img = Image.FromFile(fullpath);
                ImageConverter ic = new ImageConverter();
                byte[] xByte = (byte[])ic.ConvertTo(img, typeof(byte[]));
                local = string.Format("data:image/jpg;base64,{0}", Convert.ToBase64String(xByte));
            } catch { }
            
            return local;
        }
    }
}