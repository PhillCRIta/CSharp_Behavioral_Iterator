### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Iterator pattern
 The iterator pattern change the internals of IEnumerate object shouldn't cause any problem to the consumer. \
 For example if in internal class i change the ienumerator object from list to array i won't have a count property and the client throws me an error. \
 The iteretor must is an interface because the concrete classes can change base of data structure. \
 Iterator satisfay the Single Responsability Principle, the logic is separate from concrete class and open-closed principle. \
 You can create new colletion without modify the the exsisting collector class.