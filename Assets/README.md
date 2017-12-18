## compilation error solution

+ ArgumentException
	+ Error:

```
ArgumentException: The Assembly System.Configuration is referenced by System.Data. But the dll is not allowed to be included or could not be found.
```

	+ [Solution](http://blog.csdn.net/ljasdf123/article/details/52448419):

```
Edit->Project Settings->Player(player settings): api capability level: change ".Net 2.0 Sub" to ".Net 2.0" 
```