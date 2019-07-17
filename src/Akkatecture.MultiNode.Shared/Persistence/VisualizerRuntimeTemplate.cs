﻿// The MIT License (MIT)
//
// Copyright (c) 2009 - 2018 Lightbend Inc.
// Copyright (c) 2013 - 2018 .NET Foundation
// Modified from original source https://github.com/akkadotnet/akka.net
//
// Copyright (c) 2018 - 2019 Lutando Ngqakaza
// https://github.com/Lutando/Akkatecture 
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//-----------------------------------------------------------------------

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------


using Akka.MultiNodeTestRunner.Shared.Extensions;

namespace Akka.MultiNodeTestRunner.Shared.Persistence
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class VisualizerRuntimeTemplate : VisualizerRuntimeTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n<html>\r\n<head>\r\n\t<script src=\"https://cdnjs.cloudflare.com/ajax/libs/vis/4.8.1/" +
                    "vis.min.js\"></script>\r\n\t<link href=\"https://cdnjs.cloudflare.com/ajax/libs/vis/4" +
                    ".8.1/vis.min.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n\t<style type=\"text/css\">\r" +
                    "\n\t\t.vis-item-one { border-color:#00AABF; background-color:#7FD4DF; }\r\n\t\t.vis-ite" +
                    "m-two { border-color:#0D9DBC; background-color:#86CEDD; }\r\n\t\t.vis-item-three { b" +
                    "order-color:#1B91B9; background-color:#8DC8DC; }\r\n\t\t.vis-item-four { border-colo" +
                    "r:#2885B6; background-color:#93C2DA; }\r\n\t\t.vis-item-five { border-color:#3679B3;" +
                    " background-color:#9ABCD9; }\r\n\t\t.vis-item-six { border-color:#446DB0; background" +
                    "-color:#A1B6D7; }\r\n\t\t.vis-item-seven { border-color:#5161AD; background-color:#A" +
                    "8B0D6; }\r\n\t\t.vis-item-eight { border-color:#5F55AB; background-color:#AFAAD5; }\r" +
                    "\n\t\t.vis-item-nine { border-color:#6D48A8; background-color:#B6A3D3; }\r\n\t\t.vis-it" +
                    "em-ten { border-color:#7A3CA5; background-color:#BC9DD2; }\r\n\t\t.vis-item-eleven {" +
                    " border-color:#8830A2; background-color:#C397D0; }\r\n\t\t.vis-item-twelve { border-" +
                    "color:#96249F; background-color:#CA91CF; }\r\n\t\t.vis-item-thirteen { border-color:" +
                    "#A3189C; background-color:#D18BCD; }\r\n\t\t.vis-item-fourteen { border-color:#B10C9" +
                    "9; background-color:#D885CC; }\r\n\t\t.vis-item-fifteen { border-color:#BF0097; back" +
                    "ground-color:#DF7FCB; }\r\n\t\tdiv.cross-image {\r\n\t\t\twidth:            16px;\r\n\t\t\thei" +
                    "ght:           16px;\r\n\t\t\tbackground-image: url(\'data:image/png;base64,iVBORw0KGg" +
                    "oAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQW" +
                    "RvYmUgSW1hZ2VSZWFkeXHJZTwAAAIhSURBVDjLlZPrThNRFIWJicmJz6BWiYbIkYDEG0JbBiitDQgm0P" +
                    "uFXqSAtKXtpE2hNuoPTXwSnwtExd6w0pl2OtPlrphKLSXhx07OZM769qy19wwAGLhM1ddC184+d18QMz" +
                    "oq3lfsD3LZ7Y3XbE5DL6Atzuyilc5Ciyd7IHVfgNcDYTQ2tvDr5crn6uLSvX+Av2Lk36FFpSVENDe3Ox" +
                    "DZu8apO5rROJDLo30+Nlvj5RnTlVNAKs1aCVFr7b4BPn6Cls21AWgEQlz2+Dl1h7IdA+i97A/geP65Wh" +
                    "bmrnZZ0GIJpr6OqZqYAd5/gJpKox4Mg7pD2YoC2b0/54rJQuJZdm6Izcgma4TW1WZ0h+y8BfbyJMwBmS" +
                    "xkjw+VObNanp5h/adwGhaTXF4NWbLj9gEONyCmUZmd10pGgf1/vwcgOT3tUQE0DdicwIod2EmSbwsKE1" +
                    "P8QoDkcHPJ5YESjgBJkYQpIEZ2KEB51Y6y3ojvY+P8XEDN7uKS0w0ltA7QGCWHCxSWWpwyaCeLy0BkA7" +
                    "UXyyg8fIzDoWHeBaDN4tQdSvAVdU1Aok+nsNTipIEVnkywo/FHatVkBoIhnFisOBoZxcGtQd4B0GYJNZ" +
                    "sDSiAEadUBCkstPtN3Avs2Msa+Dt9XfxoFSNYF/Bh9gP0bOqHLAm2WUF1YQskwrVFYPWkf3h1iXwbvqG" +
                    "fFPSGW9Eah8HSS9fuZDnS32f71m8KFY7xs/QZyu6TH2+2+FAAAAABJRU5ErkJggg==\');\r\n\t\t}\r\n\t\tdi" +
                    "v.tick-image {\r\n\t\t\twidth:            16px;\r\n\t\t\theight:           16px;\r\n\t\t\tbackg" +
                    "round-image: url(\'data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf" +
                    "8/9hAAAABGdBTUEAAK/INwWK6QAAABl0RVh0U29mdHdhcmUAQWRvYmUgSW1hZ2VSZWFkeXHJZTwAAAGr" +
                    "SURBVDjLvZPZLkNhFIV75zjvYm7VGFNCqoZUJ+roKUUpjRuqp61Wq0NKDMelGGqOxBSUIBKXWtWGZxAv" +
                    "obr8lWjChRgSF//dv9be+9trCwAI/vIE/26gXmviW5bqnb8yUK028qZjPfoPWEj4Ku5HBspgAz941IXZ" +
                    "eze8N1bottSo8BTZviVWrEh546EO03EXpuJOdG63otJbjBKHkEp/Ml6yNYYzpuezWL4s5VMtT8acCMQc" +
                    "b5XL3eJE8VgBlR7BeMGW9Z4yT9y1CeyucuhdTGDxfftaBO7G4L+zg91UocxVmCiy51NpiP3n2treUPuj" +
                    "L8xhOjYOzZYsQWANyRYlU4Y9Br6oHd5bDh0bCpSOixJiWx71YY09J5pM/WEbzFcDmHvwwBu2wnikg+lE" +
                    "j4mwBe5bC5h1OUqcwpdC60dxegRmR06TyjCF9G9z+qM2uCJmuMJmaNZaUrCSIi6X+jJIBBYtW5Cge7cd" +
                    "7sgoHDfDaAvKQGAlRZYc6ltJlMxX03UzlaRlBdQrzSCwksLRbOpHUSb7pcsnxCCwngvM2Rm/ugUCi84f" +
                    "ycr4l2t8Bb6iqTxSCgNIAAAAAElFTkSuQmCC\');\r\n\t\t}\r\n\t\tdiv.border {\r\n\t\t\tborder-style: d" +
                    "ashed;\r\n\t\t\tborder-width: thin;\r\n\t\t\tmargin-bottom: 5px;\r\n\t\t}\r\n\t</style>\r\n\t<title>" +
                    "");
            
            #line 43 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(Prefix); 
            
            #line default
            #line hidden
            this.Write(@"</title>
</head>
<body>
<details>
	<summary>Help / Instructions</summary>
	<p>Click on a timeline to activate. Click off the timeline or press ESC to deactivate</p>
	<p>Scroll up to zoom into an active timeline. Scroll down to zoom out of an active timeline</p>
	<p>Click and hold to move an active timeline.</p>
</details>
");
            
            #line 52 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 foreach (var spec in Tree.Specs) { 
            
            #line default
            #line hidden
            this.Write("<div class=\"border\">\r\n<h3>");
            
            #line 54 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(spec.FactName.Replace(Prefix, "")); 
            
            #line default
            #line hidden
            this.Write("</h3>\r\n<div id=\"");
            
            #line 55 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(BuildSpecificationId(spec)); 
            
            #line default
            #line hidden
            this.Write("\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n\tvar container = document.getElement" +
                    "ById(\'");
            
            #line 58 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(BuildSpecificationId(spec)); 
            
            #line default
            #line hidden
            this.Write("\');\r\n\r\n\tvar items = [\r\n\t\t");
            
            #line 61 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(BuildTimelineItem(spec)); 
            
            #line default
            #line hidden
            this.Write("\t];\r\n\r\n\tvar groups = [\r\n\t\t");
            
            #line 65 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(BuildGroupItems(spec)); 
            
            #line default
            #line hidden
            this.Write("\t];\r\n\r\n\tvar options = ");
            
            #line 68 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 Write(BuildOptions(spec)); 
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\tvar timeline = new vis.Timeline(container, items, groups, options);\r\n</scri" +
                    "pt>\r\n</div>\r\n");
            
            #line 73 "C:\akka\akka.net\src\core\Akka.MultiNodeTestRunner.Shared\Persistence\VisualizerRuntimeTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("</body>\r\n</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class VisualizerRuntimeTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
