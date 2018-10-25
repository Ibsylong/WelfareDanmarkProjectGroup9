using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WelfareDanmarkProjectGroup9.Models
{
    public class Patient
    {

        private string _key;

        private string Key
        {
            get
            {
                if(_key == null)
                {
                    _key = Regex.Replace(Firstname.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value;  }
        }

        [DataType(DataType.Text)]
        public string Firstname { get; set; }

        [DataType(DataType.Text)]
        public string Lastname { get; set; }

        [DataType(DataType.Text)]
        public int ID { get; set; }

        [DataType(DataType.Text)]
        public string PhoneNum { get; set; }

        [DataType(DataType.Text)]
        public string EmailAddr { get; set; }

        [DataType(DataType.Text)]
        public int Age { get; set; }

        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [DataType(DataType.Text)]
        public string HomeAddr { get; set; }

        [DataType(DataType.Text)]
        public string TypeOfDementia { get; set; }

        [DataType(DataType.Text)]
        public string CaregiverName { get; set; }

        [DataType(DataType.Text)]
        public string CaregiverPhone { get; set; }

    }
}
