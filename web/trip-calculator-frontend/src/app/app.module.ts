import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatCardModule, MatButtonModule, MatIconModule, MatInputModule, MatListModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { Routes, RouterModule } from '@angular/router';
import { CalculatorComponent } from './calculator/calculator.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AbsoluteValuePipe } from './absolute-value.pipe';

const appRoutes: Routes = [
  { path: '', component: CalculatorComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    CalculatorComponent,
    AbsoluteValuePipe,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    MatCardModule,
    MatButtonModule,
    MatInputModule,
    MatListModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true },
    ),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
