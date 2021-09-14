function Person (name){
    this.name=name;
}
Person.prototype.Introduce = function(){
    console.log('Hello, my name is '+ this.name);
}
var Ilgaz = new Person("Ilgaz");
Ilgaz.Introduce();
