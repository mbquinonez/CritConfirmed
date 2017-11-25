import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from "rxjs/Observable";
import { CharacterDTO } from "../Types/CharacterDTO";

@Component({
    selector: 'cc-characters',
    templateUrl: './characters.component.html',
    styleUrls: ['./characters.component.css']
})
export class CharactersComponent implements OnInit {

    characterList: CharacterDTO[];

    constructor(private http: HttpClient) { }

    ngOnInit() {
        this.GetCharacters()
            .subscribe(characters => this.characterList = characters);
    }

    private GetCharacters(): Observable<CharacterDTO[]> {
        return this.http.get<CharacterDTO[]>("/api/Characters");
    }
}
