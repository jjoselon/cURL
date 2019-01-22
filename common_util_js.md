Get event tiggered:
```javascript
console.log(`event fired ${event.type}`); 
```

Get name of the function and its caller

```javascript
console.log(`Function ${arguments.callee.name.toString()} called ${Function.caller == null ? 'from the top' : 'by ' + Function.caller}`)
```
