using System;
using System.Collections.Generic;
using System.Text;

namespace The_Capstone_Project
{
    public class Photophograhy
    {
        #region ENUMS
        
        public enum Pictures
        {
            street,
            wildlife,
            sports,
            profiles
        }

        #endregion

        #region FIELDS

        private string _name;
        private int _style;
        private bool _favor;
        private Pictures _portraits;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Style
        {
            get { return _style; }
            set { _style = value; }
        }
        public bool Favor
        {
            get { return _favor; }
            set { _favor = value; }
        }
        public Pictures Portraits
        {
            get { return _portraits; }
            set { _portraits = value; }
        }
        #endregion
    }
}
