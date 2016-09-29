namespace Rito_Take_2.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

    export class ChampionsController {
        public champs;
        public champ;
        public getChamp() {
            this.$http.get('/api/champs/' + this.champ.id).then((response) => { this.champ = response.data })
        };
        constructor(private $http: ng.IHttpService) {
            $http.get<any>('/api/champs').then((results) => {
                this.champs = results.data.data;
            });
        }
    }

}
////'https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?api_key=4ea62465-85f2-4964-8350-657bee2e0f4c'