import Vue from 'vue'
import App from './DefaultPage.vue'

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#DefaultPage');
