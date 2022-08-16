var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Component, Input } from '@angular/core';
let OrderFormCarComponent = class OrderFormCarComponent {
};
__decorate([
    Input()
], OrderFormCarComponent.prototype, "order", void 0);
__decorate([
    Input()
], OrderFormCarComponent.prototype, "freecars", void 0);
OrderFormCarComponent = __decorate([
    Component({
        selector: "order-form-car",
        templateUrl: './order-form-car.component.html'
    })
], OrderFormCarComponent);
export { OrderFormCarComponent };
//# sourceMappingURL=order-form-car.component.js.map