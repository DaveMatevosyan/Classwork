using System;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | 
        AttributeTargets.Method, AllowMultiple = true)]
    internal class BugFixedAttribute : Attribute
    {
        private int bugNumber;
        private string description;
        public BugFixedAttribute(string description)
        {
            this.description = description;
        }

        public BugFixedAttribute(int bugNumber, string description)
        {
            this.bugNumber = bugNumber;
            this.description = description;
        }

        public override string ToString()
        {
            return this.bugNumber != 0 ?
                $"{this.bugNumber} : {this.description}" :
                this.description;
        }
    }
}