using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class MergeDataModels
{
    public static List<TestMergeModel1> GetTestData1() {
        var ds = new List<TestMergeModel1>();
        for (int i = 0; i < 10; i++) {
            ds.Add(new TestMergeModel1 {
                FirstName1 = "First Name_1_" + i,
                LastName1 = "LastName_1_" + i,
                Address1 = "Address_1_" + i
            });
        }
        return ds;
    }
    public static List<TestMergeModel2> GetTestData2() {
        var ds = new List<TestMergeModel2>();
        for (int i = 0; i < 10; i++) {
            ds.Add(new TestMergeModel2 {
                FirstName2 = "First Name_2_" + i,
                LastName2 = "LastName_2_" + i,
                Address2 = "Address_2_" + i
            });
        }
        return ds;
    }	
}

public class TestMergeModel1
{
    public string FirstName1 { get; set; }
    public string LastName1 { get; set; }
    public string Address1 { get; set; }
}

public class TestMergeModel2
{
    public string FirstName2 { get; set; }
    public string LastName2 { get; set; }
    public string Address2 { get; set; }
}