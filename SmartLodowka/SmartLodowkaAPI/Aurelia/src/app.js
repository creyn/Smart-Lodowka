export class App 
{
    configureRouter(config, router) 
    {
        config.title = 'Aurelia';
        config.map([
          { route: [''], name: 'events', moduleId: './events', nav: true, title:'Events' }
        ]);

        this.router = router;
    }
}

  