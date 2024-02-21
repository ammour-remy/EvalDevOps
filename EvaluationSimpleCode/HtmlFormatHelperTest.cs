using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace EvaluationSimpleCode
{
    [TestClass]
    public class HtmlFormatHelperTest
    {
        [TestMethod]
        public void GetStrongFormat_WithText_ReturnsStrongFormattedText()
        {
            var htmlFormatHelper = new HtmlFormatHelper();
            var inputText = "Hello, world!";

            var result = htmlFormatHelper.GetStrongFormat(inputText);

            Assert.AreEqual("<strong>Hello, world!</strong>", result);
        }
        [TestMethod]
        public void GetStrongFormat_WithText_NotReturnsStrongFormattedText()
        {
            //Je ne vois pas comment tester la methode en false
            var htmlFormatHelper = new HtmlFormatHelper();
            var inputText = "Hello, world!";

            var result = htmlFormatHelper.GetStrongFormat(inputText);

            Assert.AreEqual("<strong>Hello, world!</strong>", result);
        } 
        [TestMethod]
        public void GetItalicFormat_WithText_ReturnsItalicFormattedText()
        {
            var htmlFormatHelper = new HtmlFormatHelper();
            var inputText = "Hello, world!";

            var result = htmlFormatHelper.GetItalicFormat(inputText);

            Assert.AreEqual("<i>Hello, world!</i>", result);
        }
        [TestMethod]
        public void GetItalicFormat_WithText_NotReturnsItalicFormattedText()
        {
            //Je ne vois pas comment tester la methode en false
            var htmlFormatHelper = new HtmlFormatHelper();
            var inputText = "Hello, world!";

            var result = htmlFormatHelper.GetItalicFormat(inputText);

            Assert.AreEqual("<i>Hello, world!</i>", result);
        }
        [TestMethod]
        public void GetFormattedListElements_WithList_ReturnsFormattedList()
        {
            var htmlFormatHelper = new HtmlFormatHelper();
            var inputList = new List<string> { "Item 1", "Item 2", "Item 3" };

            var result = htmlFormatHelper.GetFormattedListElements(inputList);

            Assert.AreEqual("<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>", result);
        } 
        [TestMethod]
        public void GetNotFormattedListElements_WithList_ReturnsFormattedList()
        {
            //Je ne vois pas comment tester la methode en false
            var htmlFormatHelper = new HtmlFormatHelper();
            var inputList = new List<string> { "Item 1", "Item 2", "Item 3" };

            var result = htmlFormatHelper.GetFormattedListElements(inputList);

            Assert.AreEqual("<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>", result);
        }
    }
}
