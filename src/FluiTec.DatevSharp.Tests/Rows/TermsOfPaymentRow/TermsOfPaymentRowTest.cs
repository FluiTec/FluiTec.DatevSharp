﻿using FluiTec.DatevSharp.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluiTec.DatevSharp.Tests.Rows.TermsOfPaymentRow;

[TestClass]
public class TermsOfPaymentRowTest : RowTest
{
    public override IDatevRow CreateRow() => new DatevSharp.Rows.TermsOfPaymentRow.TermsOfPaymentRow();
}