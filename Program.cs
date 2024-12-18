/*
 change the internals of IEnumerate object shouldn't cause any problem to the consumer
 for example if in internal class i change the ienumerator object from list to array i won't have a count property and the client throws me an error
 the iteretor must is an interface because the concrete classes can change base of data structure
 iterator satisfay the Single Responsability Principle, the logic is separate from concrete class
 and open-closed principle, you can create new colletion without modify the the exsisting collector class
 */


using Behavioral_Iterator;

OrderListCollector list = new OrderListCollector();
list.Push("Ordine 1");
list.Push("Ordine 2");
list.Push("Ordine 3");


//if the IEnumerator change inside a OrderListCollector, this iterator continues to function
//because the method is defined in inerface, and not directly into the class
IIterator<string> iterator = list.CreateIterator();
while (iterator.HasNext())
{
	Console.WriteLine("I'm iterating: " + iterator.Current());
	iterator.Next();
}
