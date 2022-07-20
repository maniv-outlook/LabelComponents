using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelComponents.Areas.MyFeature.Pages
{
    public partial class UploaderControl
    {
        [Parameter]
        public string ID
        {
            get;
            set;
        }

        [Parameter]
        public string Placeholder
        {
            get;
            set;
        }

        [Parameter]
        public bool Multiple
        {
            get;
            set;
        }

        [Parameter]
        public bool AutoUpload
        {
            get;
            set;
        }

        [Parameter]
        public bool SequentialUpload
        {
            get;
            set;
        }

        [Parameter]
        public EventCallback<UploadChangeEventArgs> OnFileUpload
        {
            get;
            set;
        }
    }
}
