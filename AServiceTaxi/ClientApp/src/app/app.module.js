var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { ListComponent } from './list.component';
import { CarListComponent } from './car-list.component';
import { OrderListComponent } from './order-list.component';
import { CarFormComponent } from './car-form.component';
import { OrderFormComponent } from './order-form.component';
import { OrderFormComplateComponent } from './order-form-complate.component';
import { OrderFormCarComponent } from './order-form-car.component';
import { CarCreateComponent } from './car-create.component';
import { OrderCreateComponent } from './order-create.component';
import { CarEditComponent } from './car-edit.component';
import { OrderEditComponent } from './order-edit.component';
import { NotFoundComponent } from './not-found.component';
import { DataService } from './data.service';
const appRoutes = [
    { path: '', component: ListComponent },
    { path: 'cars', component: CarListComponent },
    { path: 'orders', component: OrderListComponent },
    { path: 'createCar', component: CarCreateComponent },
    { path: 'createOrder', component: OrderCreateComponent },
    { path: 'cars/editCar/:id', component: CarEditComponent },
    { path: 'orders/editOrder/:id', component: OrderEditComponent },
    { path: '**', component: NotFoundComponent }
];
let AppModule = class AppModule {
};
AppModule = __decorate([
    NgModule({
        imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
        declarations: [AppComponent, ListComponent, CarListComponent, OrderListComponent, CarCreateComponent, OrderCreateComponent, CarEditComponent, OrderEditComponent,
            CarFormComponent, OrderFormComponent, OrderFormComplateComponent, OrderFormCarComponent, NotFoundComponent],
        providers: [DataService],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map