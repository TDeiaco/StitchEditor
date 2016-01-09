using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StitchEditor
{
    class Stitch
    {
        private int _stitchID;

        public int StitchID
        {
            get { return _stitchID; }
            set { _stitchID = value; }
        }

        private int _connections;

        public int Connections
        {
            get { return _connections; }
            set { _connections = value; }
        }
        
        private int _stitchType;

        public int StitchType
        {
            get { return _stitchType; }
            set { _stitchType = value; }
        }

        private int _stitchSize;

        public int StitchSize
        {
            get { return _stitchSize; }
            set { _stitchSize = value; }
        }

        private int _yarnType;

        public int YarnType
        {
            get { return _yarnType; }
            set { _yarnType = value; }
        }

        private int _yarnSize;

        public int YarnSize
        {
            get { return _yarnSize; }
            set { _yarnSize = value; }
        }
        
    }
}
