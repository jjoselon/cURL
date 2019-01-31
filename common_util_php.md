
# Operador de fusion null [link](http://php.net/manual/es/migration70.new-features.php#migration70.new-features.null-coalesce-op)
```php
# SI $_POST["ANYTHING"] existe y no es NULL
echo $_POST["ANYTHING"] ?? "La variable es nula o no existe";
```

# Operador ternario (shortcut) [link](https://lornajane.net/posts/2015/new-in-php-7-null-coalesce-operator)
**Podemos saltar el segundo parametro si este es igual al primero** 
```php
$foo = "bar";
echo $foo ? $foo : "no exits";
// es equivalente a 
echo $foo ?: "no exists"
```
