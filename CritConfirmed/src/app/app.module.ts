import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule, HttpClient } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CharactersComponent } from './characters/characters.component';


@NgModule({
    declarations: [
        AppComponent,
        CharactersComponent
    ],
    imports: [
        HttpClientModule,
        BrowserModule,
        FormsModule,
        HttpModule
    ],
    providers: [HttpClientModule, HttpModule],
    bootstrap: [AppComponent]
})
export class AppModule { }
