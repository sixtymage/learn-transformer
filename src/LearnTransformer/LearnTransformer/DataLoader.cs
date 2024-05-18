using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTransformer
{
  internal class DataLoader(string path)
  {
    public void Load()
    {
      var content = File.ReadAllText(path);
      var a = content.Distinct().ToImmutableSortedSet();
      Console.WriteLine(string.Join("", a));
      Console.WriteLine(a.Count);
    }
  }
}
