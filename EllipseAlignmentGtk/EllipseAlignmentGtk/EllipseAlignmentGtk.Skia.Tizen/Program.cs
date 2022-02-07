using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace EllipseAlignmentGtk.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new EllipseAlignmentGtk.App(), args);
            host.Run();
        }
    }
}
