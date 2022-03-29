using FluiTec.DatevSharp.Rows.TermsOfPaymentRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Categories;

[TestClass]
public class TermsOfPaymentCategoryTest : BaseDataCategoryTest
{
    public TermsOfPaymentCategoryTest() : base("TermsOfPayment", "Zahlungsbedingungen", typeof(TermsOfPaymentRow))
    {
    }

    protected override DataCategory GetCategory()
    {
        return DataCategories.Instance.TermsOfPaymentCategory;
    }
}