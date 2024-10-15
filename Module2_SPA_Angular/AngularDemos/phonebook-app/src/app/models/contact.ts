export class Contact {
    id:number=1;
    firstname?:string='';
    lastname?:string='';
    gender:string='';
    dob?:string;
    email?:string='';
    phone?:string='';
    city?:string='';
    state?:string='';
    country?:string='';
    picture?:string='../../assets/images/1.jpg';

    constructor(id:number,firstname:string,lastname:string,gender:string,dob:string,email:string,phno:string,
        city:string,state:string,country:string,pictureUrl:string
    ){

        this.id=id;
        this.firstname=firstname;
        this.lastname=lastname;
        this.gender=gender;
        this.dob=dob;
        this.phone=phno;
        this.email=email;
        this.city=city;
        this.state=state;
        this.country=country;
        this.picture=pictureUrl;
    }
}
