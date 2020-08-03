import {Person} from '@/model/person';

const $ = require('jquery');

export default class PersonService {

    getPersons(): Array<Person> {
        $.get('http://localhost:62873/Default', function (data) {
            console.log(data);
        });


        var result = new Array<Person>();

        result.push({
            name: 'Domca'
        });
        result.push({
            name: 'Evička'
        });


        return result;
    }

}
