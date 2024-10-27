let person ={
    fname :'John',
    lname:'Doe',
    age : 25,
    greet : function() {
        return "Hello "+ this.fname;
    }
}
console.log(person.fname);
console.log(person.greet());