using System;
using AppStudio.DataProviders;

namespace WindowsAppStudio.Sections
{
    /// <summary>
    /// Implementation of the PhotoLeft1Schema class.
    /// </summary>
    public class PhotoLeft1Schema : SchemaBase
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string PersonalSummary { get; set; }

        public string Image { get; set; }

        public string Other { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public string Thumbnail { get; set; }
    }
}
