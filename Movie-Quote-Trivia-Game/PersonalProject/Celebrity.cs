using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    //Celebrity class that contains a name, birthday,and image
    internal class Celebrity
    {
        private string name;

        public string Name
        {
            get
            {
                if (name == null || name =="")
                {
                    name = "Jeff";
                }
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday { get; set; }

        public Image Image { get; set; }
        public Celebrity (string initialName, DateTime initialBirthday, Image initialImage)
        {
            Name = initialName;
            Birthday = initialBirthday;
            Image = initialImage;
        }

    }

}


