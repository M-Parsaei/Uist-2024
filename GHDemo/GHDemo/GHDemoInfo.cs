using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace GHDemo
{
    public class GHDemoInfo : GH_AssemblyInfo
    {
        public override string Name => "GHDemo";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("5968e5a2-779b-4045-80c9-1c61f6a25a21");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}