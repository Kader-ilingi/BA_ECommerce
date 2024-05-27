using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Common.ImageHelper
{
    public static class ImageHelper
    {
        public static string Upload (string imageName)
        {
            //png, jpg, jpeg, gif, bmp vs.

            string newImageName = "";
            string uniqueName=Guid.NewGuid().ToString();

            //parçalara ayırma
            var fileArray=imageName.Split('.');
            var extension = fileArray[fileArray.Length-1];//görselin uzantısını verecektir bize

            if (extension == "png" || extension == "jpg" || extension == "bmp" || extension == "gif" || extension == "jpeg")
            {
                newImageName = uniqueName + "." + extension;
                return newImageName;
            }
            else
            {
                return "0";
            }
        }
    }
}
