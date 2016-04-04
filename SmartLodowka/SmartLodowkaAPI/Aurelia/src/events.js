import {inject} from 'aurelia-framework';
import {HttpClient} from 'aurelia-fetch-client';
import 'fetch';

@inject(HttpClient)
export class Events 
{
    heading = 'Smart Lodówka Events';
    events = [];

    constructor(http) 
    {
        http.configure(config => {
            config
              .useStandardConfiguration()
              .withBaseUrl('http://smartlodowka.creyn.pl/api/')
              //.withBaseUrl('http://localhost:62711/api/')
              .withDefaults({
                  headers: {
                      'Accept': 'application/json'
                  }
              })
            ;
        });

        this.http = http;
    }

    activate() 
    {
        return this.http.fetch('events')
            .then(response => response.json())
            .then(json => this.events = json)
    }
}

