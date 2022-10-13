namespace TDD;

[TestFixture]
public class Tests
{
    Maths operation=null;
    Maths operation1=null;
    Maths operation2=null;

    [SetUp]
    public void Setup()
    {
        
        operation = new Maths();
        operation1 = new Maths();
        operation2 = new Maths();
       


    }

    [Test]
    public void Test1()
    {
        int result = operation.Addition(10,11);

        Assert.That(result,Is.EqualTo(21));
    }
    [TestCase(10,55,65)]
    
    public void IsAddition(int value1,int value2,int result)
    {
        int output=operation.Addition(value1,value2); 
        Assert.AreEqual(output,result);
    }
    [TestCase(1.1,5.3,6.4)]
    public void IsAddtion(double value1,double value2,double result)
    {
        dynamic output= operation1.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }


}