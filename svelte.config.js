import adapter from '@sveltejs/adapter-static';

const config = {
	kit: {
		adapter: adapter({pages: 'dist', assets: 'dist'}),
		target: '#svelte',
		files: {
			assets: 'src/Presentation/assets',
			hooks: 'src/Presentation/hooks',
			lib: 'src/Presentation/lib',
			routes: 'src/Presentation/pages',
			serviceWorker: 'src/Presentation/service-worker',
			template: 'src/Presentation/app.html'
		}
	},
};

export default config;
