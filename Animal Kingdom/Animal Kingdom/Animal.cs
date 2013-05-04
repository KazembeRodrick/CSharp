using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Kingdom
{
    class Animal
    {
        protected string _name = string.Empty;
        protected string _family = string.Empty;
        protected string _food = string.Empty;

        public Animal()
        {
            this._name = "Goat";
            this._family = "Bovidae";
            this._food = "Green vegetation";
        }

        public string name {
            get { return this._name; } //retrieve the value of _name
            set { this._name = value; } //set the value of _name
        }

        public string family
        {
            get { return this._family; } //retrieve the value of _name
            set { this._family = value; } //set the value of _name
        }

        public string food
        {
            get { return this._food; } //retrieve the value of _name
            set { this._food = value; } //set the value of _name
        }
    }
}
