using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class CDBuilder
    {
        public CDType BuildSonyCDType()
        {
            CDType cdType = new CDType();
            cdType.AddItem(new Sony());
            return cdType;
        }

        public CDType BuildSamsungCDType()
        {
            CDType cdType = new CDType();
            cdType.AddItem(new Samsung());
            return cdType;
        }
    }
}
