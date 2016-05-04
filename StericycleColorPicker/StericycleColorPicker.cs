using MyUtilities;
using RightNow.AddIns.AddInViews;
using System;
using System.AddIn;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StericycleColorPicker
{
    public class StericycleColorPickerClass : Panel, IWorkspaceComponent2
    {

        private IRecordContext _recordContext;
        public bool _inDesingMode;
        public IGlobalContext _globalContext;
        public ColorChooser ColorChooser;
        private RightNowCWS _rnSrv;
        private ColorChooser colorChooser;

        public StericycleColorPickerClass(bool inDesignMode, IRecordContext RecordContext, IGlobalContext GlobalContext)
        {
            _recordContext = RecordContext;
            _globalContext = GlobalContext;
            _inDesingMode = inDesignMode;
            if (_recordContext != null)
            {
                _recordContext.DataLoaded += LoadColorData;
                _recordContext.Saving += SaveColorData;
            }

        }

        public void LoadColorData(object sender, EventArgs e)
        {
            
            //Now lets load directly, if the performance is slow we may use a background worker.
            IGenericObject genObj = (IGenericObject)_recordContext.GetWorkspaceRecord("Chat$ChatSettings");

            IList<IGenericField> fields = genObj.GenericFields;
            
            
            foreach (IGenericField genField in fields)
            {
                //MessageBox.Show("Field Name: " + genField.Name + " Field Value: " + genField.DataValue.Value.ToString());
                String existingValue = (genField.DataValue.Value!=null)?genField.DataValue.Value.ToString():"";
                   
                if (genField.Name=="BackgroundColor" && existingValue!="")
                {
                    ColorChooser.AssignBackgroundColor(genField.DataValue.Value.ToString());  
                }
                else if (genField.Name == "TextColor" && existingValue!="")
                {
                    ColorChooser.AssignTextColor(genField.DataValue.Value.ToString());
                }
                else if (genField.Name == "RequiredColor" && existingValue!="")
                {
                    ColorChooser.AssignRequiredColor(genField.DataValue.Value.ToString());
                }
                else
                {
                    continue;
                }
            }

        }

      

        public void SaveColorData(object sender, EventArgs e)
        {
            String bc = ColorChooser.BackgroundColor.Text;
            String tc = ColorChooser.TextColor.Text;
            String rc = ColorChooser.RequiredColor.Text;

            //Now fetch the work space Again and save the data.
            IGenericObject genObj = (IGenericObject)_recordContext.GetWorkspaceRecord("Chat$ChatSettings");

            IList<IGenericField> fields = genObj.GenericFields;

            foreach (IGenericField genField in fields)
            {
                //MessageBox.Show("Field Name: " + genField.Name + " Field Value: " + genField.DataValue.Value.ToString());
                if (genField.Name == "BackgroundColor")
                {
                    genField.DataValue.Value = bc;
                }
                else if (genField.Name == "TextColor")
                {
                    genField.DataValue.Value = tc;
                }
                else if (genField.Name == "RequiredColor")
                {
                    genField.DataValue.Value = rc;
                }
                else
                {
                    continue;
                }
            }

        }

        public bool ReadOnly
        {
            get; set;
        }

        public Control GetControl()
        {

            _rnSrv = new RightNowCWS(_globalContext);
            ColorChooser = new ColorChooser();
            return ColorChooser;


        }

        public void RuleActionInvoked(string actionName)
        {
            //throw new NotImplementedException();
        }

        public string RuleConditionInvoked(string conditionName)
        {
            throw new NotImplementedException();
        }
    }


[AddIn("Stericycle ColorPicker AddIn", Version = "1.0.0.0")]
public class StericycleColorPickerFactory : IWorkspaceComponentFactory2
{
    public IGlobalContext _globalContext;
    public IRecordContext _recordContext;
    private StericycleColorPickerClass _StericycleColorPicker;

    public System.Drawing.Image Image16
    {
        get
        {
                return Properties.Resources.AddIn32;
        }
    }

    public string Text
    {
        get
        {
            return "StericylceColorPicker AddIn";
        }
    }

    public string Tooltip
    {
        get
        {
                return "StericycleColorPickerAddIn AddIn tooltip";
        }
    }

    public IWorkspaceComponent2 CreateControl(bool inDesignMode, IRecordContext context)
    {
        _recordContext = context;
        _StericycleColorPicker = new StericycleColorPickerClass(inDesignMode, _recordContext, _globalContext);
        return _StericycleColorPicker;
       
    }

    public bool Initialize(IGlobalContext context)
    {
            _globalContext = context;
            return true;
        }
}

} //Namespace Ends here

