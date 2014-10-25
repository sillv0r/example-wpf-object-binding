using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.WpfObjectBinding
{
    public class ClassController
    {
        #region Private Members

        private readonly ClassInfo[] _data = new ClassInfo[] {
            new ClassInfo() { Name = "Calculus II" },
            new ClassInfo() { Name = "Physics" },
            new ClassInfo() { Name = "AI Algorithms and Design Considerations" },
            new ClassInfo() { Name = "Programming Patterns" },
            new ClassInfo() { Name = "Computer Networks" },
            new ClassInfo() { Name = "Building and Programming Robots" },
            new ClassInfo() { Name = "Distributed Systems" }
        };

        private ClassModel _model;

        #endregion

        public void Initialize(ClassModel model)
        {
            this._model = model;

            // The original writing of the how-to apparently didn't have the IEnumerable overload?
            this._model.Classes = new System.Collections.ObjectModel.ObservableCollection<ClassInfo>(this._data);
        }
    }
}
