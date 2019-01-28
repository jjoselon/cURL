# remove options from a select control
[link](https://stackoverflow.com/questions/1518216/jquery-remove-options-from-select?answertab=votes#tab-top)
```javascript
$('#sltControl option').each(function() {
  // $(this) is the <option> tag
  if ( $(this).val() == 'gg' ) {
    $(this).remove();
  }
});
```

# Adding options to a select control
**remove all options and add one news**
```javascript
$('#sltControl').html(`<option value='backendValue'>frontendValue</option>`)
```