using FluiTec.DatevSharp.Rows.AddressRow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Categories;

[TestClass]
public class AddressCategoryTest : BaseDataCategoryTest
{
    public AddressCategoryTest() : base("Addresses", "Debitoren/Kreditoren", typeof(AddressBaseRow))
    {
    }

    protected override DataCategory GetCategory()
    {
        return DataCategories.Instance.AddressCategory;
    }
}