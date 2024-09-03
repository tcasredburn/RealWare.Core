using RealWare.Core.API.Models.Base;

namespace RealWare.Core.API.Models
{
    public class RWListBuilderQueryItem : RWBase
    {
        public string Description
        {
            get;
            set;
        }

        public bool Embedded
        {
            get;
            set;
        }

        public long EmbeddedKey
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public long QueryID
        {
            get;
            set;
        }

        public bool Shared
        {
            get;
            set;
        }

        public bool System
        {
            get;
            set;
        }

        public string User
        {
            get;
            set;
        }

        public RWListBuilderQueryItem()
        {
        }
    }
}
