import Vue from 'vue'
import App from './DefaultPage.vue'

import { BootstrapVue, IconsPlugin } from 'bootstrap-vue';

import '../styles/custom.scss'

// Install BootstrapVue
Vue.use(BootstrapVue);
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin);

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#DefaultPage');
