using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTransformer
{
  internal class DataLoader(string path)
  {
    public void Load()
    {
      File.ReadAllText(path);
    }
  }
}
