import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CubeSummationComponent } from './cube-summation/cube-summation.component';
import { CubeSummationService } from './services/cube-summation/cube-summation.service';
import { NumericOnlyDirective } from './Directives/NumericOnlyDirective';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,    
    CubeSummationComponent,
    NumericOnlyDirective
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },      
      { path: 'cube-summation', component: CubeSummationComponent },
    ])
  ],
  providers: [
   CubeSummationService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
