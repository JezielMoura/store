import adapter from '@sveltejs/adapter-static';

const config = {
	kit: {
		adapter: adapter({ pages: 'dist', assets: 'dist' }),
		target: '#svelte',
        files: {
			assets: 'src/Presentation/assets',
			lib: 'src/Presentation/components',
			routes: 'src/Presentation/pages',
			template: 'src/Presentation/app.html'
		},
		vite: {
			server: {
				proxy: {
					'/api': {
						target: 'http://localhost:5000',
						changeOrigin: true
					}
				}
			}
		}
}
};

export default config;
