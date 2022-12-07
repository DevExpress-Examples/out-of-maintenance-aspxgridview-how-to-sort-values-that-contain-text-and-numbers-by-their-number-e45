using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {

    protected void grid_CustomColumnSort(object sender, CustomColumnSortEventArgs e) {
        if(cb_CustomSort.Checked == false)
            return;
        if(e.Column.FieldName != "value")
            return;

        int Value1_NumberPart;
        string Value1_TextPart;

        string Value1_NumberString = Regex.Match(e.Value1.ToString(), @"\d+").Value;
        if(Value1_NumberString != "") {
            Value1_NumberPart = Convert.ToInt32(Value1_NumberString);
            Value1_TextPart = e.Value1.ToString().Replace(Value1_NumberString, "").ToLower();
        }
        else {
            Value1_NumberPart = 0;
            Value1_TextPart = e.Value1.ToString().ToLower();
        }


        int Value2_NumberPart;
        string Value2_TextPart;
        string Value2_NumberString = Regex.Match(e.Value2.ToString(), @"\d+").Value;
        if(Value2_NumberString != "") {
            Value2_NumberPart = Convert.ToInt32(Value2_NumberString);
            Value2_TextPart = e.Value2.ToString().Replace(Value2_NumberString, "").ToLower();
        }
        else {
            Value2_NumberPart = 0;
            Value2_TextPart = e.Value2.ToString().ToLower();
        }


        if(Value1_TextPart != Value2_TextPart)
            e.Handled = false;
        else {
            e.Handled = true;
            e.Result = Value1_NumberPart > Value2_NumberPart ? 1 : -1;
        }
    }
}
